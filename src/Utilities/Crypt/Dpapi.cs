// file:	Crypt\Dpapi.cs
// summary:	Implements the dpapi class

namespace Utilities.Crypt
{
    using System;
    using System.Configuration;
    using System.Security.Cryptography;
    using System.Text;

    using Utilities.Extension;

    ///-------------------------------------------------------------------------------------------------
    /// <summary>   A dpapi. </summary>
    /// <remarks>   Aydin Aydin, 28/03/2015. </remarks>
    public class Dpapi
    {
        /// <summary>   The entropy. </summary>
        private readonly byte[] entropy;

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Default constructor. </summary>
        /// <remarks>   Aydin Aydin, 28/03/2015. </remarks>
        public Dpapi()
        {
            this.entropy = Encoding.UTF8.GetBytes(ConfigurationManager.AppSettings["netUtilities.dpapi.entropy"]);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Constructor. </summary>
        /// <remarks>   Aydin Aydin, 28/03/2015. </remarks>
        /// <param name="entropy">  The entropy. </param>
        /// <param name="encoding"> The encoding. </param>
        public Dpapi(string entropy, Encoding encoding)
        {
            this.entropy = encoding.GetBytes(entropy);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Decrypts. </summary>
        /// <remarks>   Aydin Aydin, 28/03/2015. </remarks>
        /// <param name="textToDecrypt">    The text to decrypt. </param>
        /// <returns>   A string. </returns>
        public string Decrypt(string textToDecrypt)
        {
            if (textToDecrypt.IsNullOrWhiteSpace())
            {
                throw new ArgumentNullException("textToDecrypt");
            }

            string decryptedText = string.Empty;

            try
            {
                byte[] encryptedBytes = Convert.FromBase64String(textToDecrypt);
                byte[] decryptedBytes = ProtectedData.Unprotect(encryptedBytes, this.entropy, DataProtectionScope.LocalMachine);
                decryptedText         = Encoding.UTF8.GetString(decryptedBytes);
            }
            catch (Exception exception)
            {

            }

            return decryptedText;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Encrypts. </summary>
        /// <remarks>   Aydin Aydin, 28/03/2015. </remarks>
        /// <param name="textToEncrypt">    The text to encrypt. </param>
        /// <returns>   A string. </returns>
        public string Encrypt(string textToEncrypt)
        {
            if (textToEncrypt.IsNullOrWhiteSpace())
            {
                throw new ArgumentNullException("textToEncrypt");
            }

            string baseEncodedEncryptedData;

            try
            {
                byte[] unprotectedData = Encoding.UTF8.GetBytes(textToEncrypt);
                byte[] encryptedData = ProtectedData.Protect(unprotectedData, this.entropy, DataProtectionScope.LocalMachine);
                string encryptedText = Encoding.UTF8.GetString(encryptedData);

                baseEncodedEncryptedData = Convert.ToBase64String(encryptedData);
            }
            catch (Exception exception)
            {
                // TODO: Add some tests, figure out  what can go wrong to give more informative messages to client.
                throw new DpapiException("Unable to encrypt");
            }

            return baseEncodedEncryptedData;
        }

    }

    public class DpapiException : Exception
    {
        public DpapiException(string message)
        {
            this.message = message;
        }

        private readonly string message;

        public override string Message
        {
            get
            {
                return this.message;
            }
        }
    }

}
