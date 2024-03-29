﻿using GeneralToolkitLib.Utility;

namespace WiFiPasswordGenerator.Settings
{
    /// <summary>
    /// Aplication current config
    /// </summary>
    public class ActiveSettings
    {
        /// <summary>
        ///  Aplication current config constructor using default values
        /// </summary>
        public ActiveSettings()
        {
            // Set default settinga
            PasswordType = PasswordTypes.StandardMixedChars;
            QR_CodeLevel = QR_CodeLevels.M;
            PasswordLength = 50;
            ImageWidth = 525;
        }

        /// <summary>
        /// Type of characters generated
        /// </summary>
        public PasswordTypes PasswordType { get; set; }
        /// <summary>
        /// Error corrextion level (L;M;Q;H) = 7,15,25,30%
        /// </summary>
        public QR_CodeLevels QR_CodeLevel { get; set; }
        /// <summary>
        /// 1-500
        /// </summary>
        public int PasswordLength { get; set; }

        /// <summary>
        /// Gets or sets the width of the image.
        /// </summary>
        /// <value>
        /// The width of the image.
        /// </value>
        public int ImageWidth { get; set; }
    }
}