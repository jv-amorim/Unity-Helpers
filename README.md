<h1 align="center">
    Unity Helpers
</h1>

<p align="center">
  <img alt="GitHub language count" src="https://img.shields.io/github/languages/count/JV-Amorim/Unity-Helpers">

  <img alt="Repository size" src="https://img.shields.io/github/repo-size/JV-Amorim/Unity-Helpers">

  <a href="https://github.com/JV-Amorim/Unity-Helpers/commits/master">
    <img alt="GitHub last commit" src="https://img.shields.io/github/last-commit/JV-Amorim/Unity-Helpers">
  </a>

  <img alt="License" src="https://img.shields.io/badge/license-MIT-brightgreen">
</p>

## Description

A set of Unity C# scripts useful for several different projects.

## Content

**TODO**
The class create these delays using StartCoroutine() and IEnumerators, needing the inheritance from MonoBehaviour.

### Camera Helpers

- **Screenshot.cs**: Class with methods to take a screenshot from the view of the camera in game runtime.

### Canvas Helpers

- **CanvasEffects.cs**: Class with methods that create effects and notifications on the selected canvas. With this class you can create a alert in the screen with a certain duration time, for example.

- **CanvasEffectsWithDelay.cs**: Very similar to the CanvasEffects.cs, this script contains a class with methods that create effects and notifications on the selected canvas. However, the methods of this class can receive as parameter a delay time to be activated.

- **CanvasItemsPaginationManager.cs**: Class that creates pagination on a set of canvas items. Examples of set of canvas items: images gallery, score ranking table.

- **CursorEffects.cs**: Class with methods that change the mouse cursor from arrow icon to link icon, and vice versa. To use this class and change the mouse cursor when hovering an element in canvas (a button, for example), you must attach this script to a GameObject and assign the arrow texture and link texture to the two public fields. The methods ChangeCursorToArrow() and ChangeCursorToLink() can be called with a EventTrigger, using the OnPointerEnter and OnPointerExit events.

- **InputFieldHelpers.cs**: Class with methods to use in the InputField or TMP_InputField component. With this class you can show or hide the content of a password field, for example.

- **ScrollbarButtons.cs**: Class with methods that allows the use of buttons to control a scrollbar.

### Email Helpers

- **EmailSender.cs**: Class that allows the asynchronous sending of an email message to an email address. The email message is created using the EmailMessage model.

- **EmailMessage.cs**: EmailMessage model.

- **EmailValidator.cs**: Class with methods that validate if an email address is valid.

### Extensions

- **ArrayExtensions.cs**: Class with extension methods for arrays of generic types. Methods: Shuffle.

- **RectTransformExtensions.cs**: Class with extension methods that allows easy resizing of canvas elements using C# code. Methods: SetLeft, SetRight, SetTop, SetBottom.

- **TextureExtensions.cs**: Class with extension methods for Texture2D objects. Methods: MergeTextures, AddWatermark, ToTexture2D.

- **TransformExtensions.cs**: Class with extension methods for components of the Transform type. Methods: FindChildrenGameObjectsWithTag.

### FileHelpers:

- **FileManagementHelpers.cs**: Class with methods to Copy and Delete Files. Also has a method that create a unique name to a file that will be copied to a directory.

### GameObjectHelpers:

- **GameObjectInstantiator.cs**: Class that allows the instantiation of GameObjects in the scene at the game runtime.

### HashingHelpers:

- **HashGenerator.cs**: Class with a method that allows the creation of SHA256 cryptographic hash from a string.

### HttpHelpers:

- **ApiDataRequester.cs**: Class that allows data requesting from an API.

- **ApiDataSender.cs**: Class that allows data sending to an API.

### SceneHelpers:

- **SceneManager.cs**: Class with methods for scene management.

### StringHelpers:

- **StringGenerator.cs**: Class with methods that allows the creation of random strings.

### TextureHelpers:

- **TextureEditor.cs**: Class with methods for editing textures, such as cropping, for example.

- **TextureLoader.cs**: Class with methods that allows getting a texture from a file or URL.

- **TextureScale.cs**: Class with methods that allows the scaling of a texture. For most cases, just using the method `public static void Bilinear(Texture2D tex, int newWidth, int newHeight)` is sufficient. [This script was taken from the Unity Community Wiki](https://wiki.unity3d.com/index.php/TextureScale).

### VirtualKeyboardHelpers (WINDOWS ONLY):

- **VirtualKeyboard.cs**: The class allows the opening and closing of the Windows virtual keyboard.

### XMLHelpers:

- **XMLReader.cs**: The class allows the reading of XML file content. The method `GetDataFromXMLFile(string path, string xmlTag)` gets the data enclosed by a XML tag. Example: `<Username>Luke Skywalker</Username>`. This method doesn't work on tags that are children of another tag.

## How to Use

1. Copy/import all folders in this repository (or just the scripts folders you want to use) to the Assets folder;
2. Import the namespace of the scripts with the features you want to use in your script. Example: add `using UnityHelpers.CanvasHelpers;` to the top of your code to use CanvasHelpers classes and methods.

## How to Contribute

To contribute with this project:

- Do a fork of this repository;
- Create a branch with your feature: `git checkout -b my-feature`;
- Commit your changes: `git commit -m 'feat: 'My feature details'`.
- Push the commits to your branch `git push origin my-feature`.

After the merge of your pull request has been made, you can delete your branch.

## License

This project is licensed under the MIT License. See the [license](https://opensource.org/licenses/MIT) page for details.