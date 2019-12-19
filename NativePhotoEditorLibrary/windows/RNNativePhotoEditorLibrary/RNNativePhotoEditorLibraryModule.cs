using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Native.Photo.Editor.Library.RNNativePhotoEditorLibrary
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNNativePhotoEditorLibraryModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNNativePhotoEditorLibraryModule"/>.
        /// </summary>
        internal RNNativePhotoEditorLibraryModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNNativePhotoEditorLibrary";
            }
        }
    }
}
