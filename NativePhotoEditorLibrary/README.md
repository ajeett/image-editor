
# react-native-native-photo-editor-library

## Getting started

`$ npm install react-native-native-photo-editor-library --save`

### Mostly automatic installation

`$ react-native link react-native-native-photo-editor-library`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-native-photo-editor-library` and add `RNNativePhotoEditorLibrary.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNNativePhotoEditorLibrary.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNNativePhotoEditorLibraryPackage;` to the imports at the top of the file
  - Add `new RNNativePhotoEditorLibraryPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-native-photo-editor-library'
  	project(':react-native-native-photo-editor-library').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-native-photo-editor-library/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-native-photo-editor-library')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNNativePhotoEditorLibrary.sln` in `node_modules/react-native-native-photo-editor-library/windows/RNNativePhotoEditorLibrary.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Native.Photo.Editor.Library.RNNativePhotoEditorLibrary;` to the usings at the top of the file
  - Add `new RNNativePhotoEditorLibraryPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNNativePhotoEditorLibrary from 'react-native-native-photo-editor-library';

// TODO: What to do with the module?
RNNativePhotoEditorLibrary;
```
  