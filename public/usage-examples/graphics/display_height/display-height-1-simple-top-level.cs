using SplashKitSDK;
using static SplashKitSDK.SplashKit;

        // Open a window
        Window window = OpenWindow("Display Height", 800, 600);
       

        // Draw display details
        for (uint i = 0; i < NumberOfDisplays(); i++)
        {
            // Retrieve display details
            var display = DisplayDetails(i);

            // Write display height to the screen
            DrawText($"Height: {display.Height}", Color.Black, "Arial", 24, 100, 100);
            

        }

        // Refresh the screen to show drawn text
        RefreshScreen();

        // Pause for 3 seconds to allow viewing
        Delay(3000);

        // Close the window
        CloseAllWindows();
