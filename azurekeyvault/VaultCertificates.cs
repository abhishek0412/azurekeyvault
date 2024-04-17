using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Azure.Identity;
using Azure.Security.KeyVault.Certificates;

namespace azurekeyvault
{

	public class VaultCertificates
	{
        string keyVaultUrl = "https://akv-terraform0412.vault.azure.net/";

        public void DownloadCertificate(string certificateName)
		{
            CertificateClient client = new CertificateClient(new Uri(keyVaultUrl), new DefaultAzureCredential());

            X509KeyStorageFlags keyStorageFlags = X509KeyStorageFlags.MachineKeySet;
            if (!RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                keyStorageFlags |= X509KeyStorageFlags.EphemeralKeySet;
            }

            DownloadCertificateOptions options = new DownloadCertificateOptions(certificateName)
            {
                KeyStorageFlags = keyStorageFlags
            };

            using X509Certificate2 certificate = client.DownloadCertificate(options);
            using RSA key = certificate.GetRSAPrivateKey();

        }
	}
}

