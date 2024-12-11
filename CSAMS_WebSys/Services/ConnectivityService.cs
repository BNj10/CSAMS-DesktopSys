using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Timers;

public class ConnectivityService
{
    private bool isConnected = false;

    public ConnectivityService()
    {
        NetworkChange.NetworkAvailabilityChanged += OnNetworkAvailabilityChanged;
    }

    public async Task<bool> CheckNetworkAvailability()
    {
        bool currentConnectionStatus = false;
        try
        {
            currentConnectionStatus = await IsInternetAvailable();

            if (!currentConnectionStatus && isConnected)
            {
                isConnected = false;
                Console.WriteLine("Connection lost. Please connect to the internet.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error while checking network status." + ex);
        }
        return currentConnectionStatus;
    }

    private async void OnNetworkAvailabilityChanged(object sender, NetworkAvailabilityEventArgs e)
    {
        if (e.IsAvailable)
        {
            Console.WriteLine("Network became available.");
            isConnected = await IsInternetAvailable();
        }
        else
        {
            Console.WriteLine("Network became unavailable.");
            isConnected = false;
        }
    }

    private async Task<bool> IsInternetAvailable()
    {
        try
        {
            using (var ping = new Ping())
            {
                var reply = await Task.Run(() => ping.Send("8.8.8.8", 3000));
                return reply != null && reply.Status == IPStatus.Success;
            }
        }
        catch
        {
            return false;
        }
    }
}
