using System.Collections.Generic;
using Azure;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;

namespace azurekeyvault;
public class Vault
{
    string keyVaultUrl = "https://akv-terraform0412.vault.azure.net/";

    public Vault()
    {

    }

    public string CreateSecret(string secretName,string secretValue)
    {
        
        // Create a new secret client using the default credential from Azure.Identity using environment variables previously set,
        // including AZURE_CLIENT_ID, AZURE_CLIENT_SECRET, and AZURE_TENANT_ID.
        var client = new SecretClient(vaultUri: new Uri(keyVaultUrl), credential: new DefaultAzureCredential());

        // Create a new secret using the secret client.
        KeyVaultSecret secret = client.SetSecret(secretName, secretValue);

        // Retrieve a secret using the secret client.
        return client.GetSecret(secretName).ToString();
    }


    public string GetSecret(string secretName)
    {
        
        // Create a new secret client using the default credential from Azure.Identity using environment variables previously set,
        // including AZURE_CLIENT_ID, AZURE_CLIENT_SECRET, and AZURE_TENANT_ID.
        var client = new SecretClient(vaultUri: new Uri(keyVaultUrl), credential: new DefaultAzureCredential());

        // Retrieve a secret using the secret client.
        return client.GetSecret(secretName).ToString();
    }

    public string DeletedSecret(string secretName)
    {
        // Create a new secret client using the default credential from Azure.Identity using environment variables previously set,
        // including AZURE_CLIENT_ID, AZURE_CLIENT_SECRET, and AZURE_TENANT_ID.
        var client = new SecretClient(vaultUri: new Uri(keyVaultUrl), credential: new DefaultAzureCredential());

        DeleteSecretOperation operation = client.StartDeleteSecret(secretName);

        DeletedSecret secret = operation.Value;
        // Retrieve a secret using the secret client.
        return secret.Name;
    }

    public Dictionary<string,string> ListSecrets()
    {
        var client = new SecretClient(vaultUri: new Uri(keyVaultUrl), credential: new DefaultAzureCredential());
    

        Dictionary<string,string> dictonaryOFSecrets = new Dictionary<string,string>();

        Pageable<SecretProperties> allSecrets = client.GetPropertiesOfSecrets();

        foreach (SecretProperties secretProperties in allSecrets)
        {
            dictonaryOFSecrets.Add(secretProperties.Name, secretProperties.KeyId.ToString());
           
            
        }

        return dictonaryOFSecrets;
    }
}

