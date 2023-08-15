using UnityEditor;
//Some code from https://stackoverflow.com/a/45219341/10047920
//To run from the command line: 
// "c:\Program Files\Unity Installs\2019.3.11f1\Editor\Unity.exe" -batchmode -logFile stdout.log -executeMethod Builder.BuildWebGL -quit 
//
//To generate a windows build, you don't need this script
// "c:\Program Files\Unity Installs\2019.3.11f1\Editor\Unity.exe" -batchmode -buildWindowsPlayer "BuildWindows/Break.exe" -nographics -quit 


class Builder {
    static void BuildWebGL() {

        // Place all your scenes here
        string[] scenes = {"Assets/Scenes/SampleScene.unity"};

        //Change this path if you want a different location.
        string pathToDeploy = "BuildWebGL/";       

        //Do the actual building.
        BuildPipeline.BuildPlayer(scenes, pathToDeploy, BuildTarget.WebGL, BuildOptions.None);      
    }
}
