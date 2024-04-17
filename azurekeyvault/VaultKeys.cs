using System.Collections.Generic;
using System.Net;
using Azure;
using Azure.Identity;
using Azure.Security.KeyVault.Keys;

namespace azurekeyvault;
public class VaultKeys
{
    string keyVaultUrl = "https://akv-terraform0412.vault.azure.net/";

    public VaultKeys()
    {

    }

    public string CreateKey(string keyName)
    {
        
        // Create a new secret client using the default credential from Azure.Identity using environment variables previously set,
        // including AZURE_CLIENT_ID, AZURE_CLIENT_SECRET, and AZURE_TENANT_ID.
        
        var client = new KeyClient(new Uri(keyVaultUrl), new DefaultAzureCredential());
        // Create a new secret using the secret client.
        KeyVaultKey key = client.CreateKey(keyName, KeyType.Rsa); 

        // Retrieve a secret using the secret client.
        return key.Name.ToString();
    }


    public string GetKey(string keyName)
    {

        // Create a new secret client using the default credential from Azure.Identity using environment variables previously set,
        // including AZURE_CLIENT_ID, AZURE_CLIENT_SECRET, and AZURE_TENANT_ID.
        var client = new KeyClient(new Uri(keyVaultUrl), new DefaultAzureCredential());

        KeyVaultKey key = client.GetKey(keyName);
        // Retrieve a secret using the secret client.
        return key.Name.ToString();
    }

    public string DeletedKey(string keyName)
    {
        // Create a new secret client using the default credential from Azure.Identity using environment variables previously set,
        // including AZURE_CLIENT_ID, AZURE_CLIENT_SECRET, and AZURE_TENANT_ID.
        var client = new KeyClient(new Uri(keyVaultUrl), new DefaultAzureCredential());

        DeleteKeyOperation operation = client.StartDeleteKey(keyName);

        DeletedKey key = operation.Value;
        // Retrieve a secret using the secret client.
        return key.Name;
    }

    public Dictionary<string,string> ListKeys()
    {
        var client = new KeyClient(new Uri(keyVaultUrl), new DefaultAzureCredential());

        Dictionary<string,string> dictonaryOFKeys = new Dictionary<string,string>();

        Pageable<KeyProperties> allSecrets = client.GetPropertiesOfKeys();

        foreach (KeyProperties keyProperties in allSecrets)
        {
            dictonaryOFKeys.Add(keyProperties.Name, keyProperties.Id.ToString());
           
            
        }

        return dictonaryOFKeys;
    }
}

