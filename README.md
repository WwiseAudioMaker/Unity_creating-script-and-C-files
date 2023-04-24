# Unity_creating-script-and-C-files
In order to incorporate responsive and interactive behaviors in Unity, it is necessary to utilize C# scripting. This allows characters within the game to perform actions such as running, jumping, and responding to commands from the player.


adding a Timer while in play mode:

In this race car game, a timer display was added to the top right-hand corner of the screen to indicate how long the game has been played. To retrieve references for an object, such as references to components at the beginning of the level, Unity provides the awake function. The awake function occurs rapidly when the level begins, making it an excellent location to obtain references. In contrast, the start function is better suited for performing initial behaviors that depend on these references being valid. Through scripting, a timer object was generated with the ability to set the text of the text component to display the elapsed time. This serves as an excellent example of the immense power of scripting within Unity, allowing for the retrieval of components from any object and the ability to update their properties.
