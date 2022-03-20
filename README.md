# CS476-Speedrun-Project

This project was developed by Isaac Atta and Kurtis Tomyn over the course of a semester as the final project for the course CS 476 at the University of Regina.
 
#  Installation Guide
* If you dont already have a Unity account you can create one [here](https://unity.com/)
* You will also need to [Install Unity Hub](https://unity3d.com/get-unity/download) and a Unity Editor Version that is atleast `2021.2.13f1` or higher
* After you have Unity installed, clone this repository or download the source code as a zip
* Open Unity Hub and click the drop down arrow next to open and select `Add project from disk`
* Navigate to the location you downloaded the repository to and you should be able to just open the folder directly as a Unity project.
* To create a new level you can navigate to the scenes folder and preview the level1 scene as an example.
* In the scenes folder you can just right-click > Create > Scene and give it a suitable name to create a blank scene.

# Level Creation guide
* Any level you create must be made in a new scene and must contain the following items:
  * A GameManager GameObject
  * A Targets empty GameObject (make sure all target prefabs you create are children of this gameobject)
  * Player Prefab
  * UI interface
  * Ending Platform Prefab
* You can directly copy and paste these items from either level1 or level2 and if you select them all together then all the references the GameManager needs of the other objects will be carried over correctly, otherwise you will have to set them yourself.
* You must make sure you place all obstacles and platforms above the Player's currently set Respawn Height.
* You can use any of the platform and tower models in the prefabs folder or even make your own using a tool like [Blender](https://www.blender.org/).
* Once you feel like you have made a suitable enough level you can submit it as a pull request to this repository so that we can review it and see if it would be a suitable fit for the game.


