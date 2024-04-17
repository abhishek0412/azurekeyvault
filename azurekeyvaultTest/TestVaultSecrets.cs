using azurekeyvault;
namespace azurekeyvaultTest;

[TestClass]
public class TestVaultSecrets

{

    static string name = EmptyClass.getName();

    [TestMethod]
    public void TestSecretsCreation()
    {
        VaultSecret myVault = new VaultSecret();
        Console.WriteLine(myVault.CreateSecret(TestVaultSecrets.name, "Choudhary"));
    }

    [TestMethod]
    public void TestSecretsRetrival()
    {
        VaultSecret myVault = new VaultSecret();
        Console.WriteLine(myVault.GetSecret("secret-sauce"));
    }

    [TestMethod]
    public void TestSecretsDeletion()
    {
        VaultSecret myVault = new VaultSecret();
        Console.WriteLine(myVault.DeletedSecret(TestVaultSecrets.name));

    }


    [TestMethod]
    public void TestSecretsListAll()
    {
        VaultSecret myVault = new VaultSecret();
        Console.WriteLine(myVault.ListSecrets());
       
    }
}
