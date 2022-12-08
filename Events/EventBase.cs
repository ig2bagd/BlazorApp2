using BlazorApp2.Events.CustomEventArgs;
using Microsoft.AspNetCore.Components;

namespace BlazorApp2.Events
{
    // https://www.youtube.com/watch?v=K2P6C9tme1c&t=196s
    // https://github.com/DavidEggenberger/DavidSeesSharp-Videos/tree/main/Blazor-GlobalEvents
    public class EventBase : ComponentBase
    {
        public static event EventHandler<WarningEventArgs> WarningTriggered;
        public static event EventHandler WarningResseted;
        public void TriggerWarning(string message)
        {
            WarningTriggered?.Invoke(this, new WarningEventArgs { Message = message });
        }
        public void ResetWarning()
        {
            WarningResseted?.Invoke(this, null);
        }
    }
}
