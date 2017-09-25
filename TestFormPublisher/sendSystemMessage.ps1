param(
    [string]$hostname="http://192.168.1.61/signalr/",
    [string]$hub="MessageRoutingBus",
    [string]$messagetext="Some message",
    [string]$topic="Topic",
    [string]$level="info"
)


#load assemblies
function loadAssemblies()
{
    #so we can redirect assemblies
    # Load your target version of the assembly
    $newtonsoft = [System.Reflection.Assembly]::LoadFrom("$PSScriptRoot\Newtonsoft.Json.dll")
    $onAssemblyResolveEventHandler = [System.ResolveEventHandler] {
      param($sender, $e)
      # You can make this condition more or less version specific as suits your requirements
      if ($e.Name.StartsWith("Newtonsoft.Json")) {
        return $newtonsoft
      }
      foreach($assembly in [System.AppDomain]::CurrentDomain.GetAssemblies()) {
        if ($assembly.FullName -eq $e.Name) {
          return $assembly
        }
      }
      return $null
    }
    [System.AppDomain]::CurrentDomain.add_AssemblyResolve($onAssemblyResolveEventHandler)

    
    [Reflection.Assembly]::LoadFile("$PSScriptRoot\MessageRouting.Shared.dll");
    [Reflection.Assembly]::LoadFile("$PSScriptRoot\Microsoft.AspNet.SignalR.Client.dll");
}

#Detach assemblies
function removeAssembly()
{
    # Detach the event handler (not detaching can lead to stack overflow issues when closing PS)
    [System.AppDomain]::CurrentDomain.remove_AssemblyResolve($onAssemblyResolveEventHandler);
}


#################### Main ############################

loadAssemblies;

#get signalR publisger object
$messagePublisher = New-Object MessageRouting.Shared.Service.SignalrPublisher -argumentlist $hostname, $hub
#startConnection("http://192.168.1.61/signalr/", "MessageRoutingBus");

#create an message
$message = New-Object MessageRouting.Shared.Model.Message
$message.Level = $level;
$message.Text = $messagetext;
$message.Topic = $topic;

$messagePublisher.Publish($message);

removeAssembly;


######################################################
