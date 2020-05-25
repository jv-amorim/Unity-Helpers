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

## Table of Contents

- [Table of Contents](#table-of-contents)
- [Description](#description)
- [Content](#content)
  - [Camera Helpers](#camera-helpers)
  - [Canvas Helpers](#canvas-helpers)
  - [Email Helpers](#email-helpers)
  - [Extensions](#extensions)
  - [File Helpers](file-helpers)
  - [GameObject Helpers](gameobject-helpers)
  - [Hashing Helpers](hashing-helpers)
  - [Http Helpers](http-helpers)
  - [Scene Helpers](scene-helpers)
  - [String Helpers](string-helpers)
  - [Texture Helpers](texture-helpers)
  - [Virtual Keyboard Helpers](virtual-keyboard-helpers)
  - [XML Helpers](xml-helpers)
- [How to Use](#how-to-use)
- [How to Contribute](#how-to-contribute)
- [License](#license)

## Description

A set of Unity C# scripts useful for several different projects.

## Content

There are three types of classes in this repository: classes that inherits from MonoBehaviour, classes that do not inherits from MonoBehaviour (and are static) and classes with extension methods. The classes of the second and third type can be used normally, that is, they can be used in the normal way that classes of static and extension methods are used. However, the first type of classes (classes that inherits from MonoBehaviour) must be attached as component of a GameObject in order to use its methods.

### Camera Helpers

- **Screenshot.cs**: Class with methods to take a screenshot from the view of the camera in game runtime.

### Canvas Helpers

- **CanvasEffects.cs**: Class with methods that create effects and notifications on the selected canvas. With this class you can create a alert in the screen with a certain duration time, for example.

- **CanvasEffectsWithDelay.cs**: Very similar to the CanvasEffects.cs, this script contains a class with methods that create effects and notifications on the selected canvas. However, the methods of this class can receive as parameter a delay time to be activated.

- **CanvasItemsPaginationManager.cs**: Class that creates pagination on a set of canvas items. Examples of set of canvas items: images gallery, score ranking table.

- **CursorEffects.cs**: Class with methods that change the mouse cursor from arrow icon to link icon, and vice versa. To use this class and change the mouse cursor when hovering an element in canvas (a button, for example), you must attach this script to a GameObject and assign the arrow texture and link texture to the two public fields. The methods ChangeCursorToArrow() and ChangeCursorToLink() can be called with a EventTrigger, using the OnPointerEnter and OnPointerExit event listeners.

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

### File Helpers:

- **FileManagementHelpers.cs**: Class with methods to Copy and Delete Files. Also has a method that create a unique name to a file that will be copied to a directory, avoiding the overwriting of an existing file.

### GameObject Helpers:

- **GameObjectInstantiator.cs**: Class that allows the instantiation of GameObjects in the scene at the game runtime.

### Hashing Helpers:

- **HashGenerator.cs**: Class with a method that allows the creation of SHA256 cryptographic hash from a string.

### Http Helpers:

- **ApiDataRequester.cs**: Class that allows data requesting from an API.

- **ApiDataSender.cs**: Class that allows data sending to an API.

### Scene Helpers:

- **SceneManager.cs**: Class with methods for scene management.

### String Helpers:

- **StringGenerator.cs**: Class with methods that allows the creation of random strings.

### Texture Helpers:

- **TextureEditor.cs**: Class with methods for editing textures, such as cropping, for example.

- **TextureLoader.cs**: Class with methods that allows getting a texture from a file or URL.

- **TextureScale.cs**: Class with methods that allows the scaling of a texture. For most cases, just using the method `public static void Bilinear(Texture2D tex, int newWidth, int newHeight)` is sufficient. [This script was taken from the Unity Community Wiki](https://wiki.unity3d.com/index.php/TextureScale).

### Virtual Keyboard Helpers:

(WINDOWS ONLY)

- **VirtualKeyboard.cs**: The class allows the opening and closing of the Windows 10 virtual keyboard.

### XML Helpers:

- **XMLReader.cs**: The class allows the reading of XML file content. The method `GetDataFromXMLFile(string path, string xmlTag)` gets the content enclosed by a XML tag. Example: `<Username>Luke Skywalker</Username>`. This method doesn't work on tags that are children of another tag.

---

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
