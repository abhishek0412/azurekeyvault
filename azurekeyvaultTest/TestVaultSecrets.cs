using azurekeyvault;
namespace azurekeyvaultTest;

[TestClass]
public class TestVaultSecrets

{
    [TestMethod]
    public void TestSecretsCreation()
    {
        VaultSecret myVault = new VaultSecret();
        //Assert.AreEqual(myVault.CreateSecret("Abhishek", "Choudhary"), "Abhishek");
        Console.WriteLine(myVault.CreateSecret("Supriya", "Choudhary"));
    }

    [TestMethod]
    public void TestSecretsRetrival()
    {
        VaultSecret myVault = new VaultSecret();
        //Assert.AreEqual(myVault.GetSecret("Abhishek"), "Abhishek");
        Console.WriteLine(myVault.GetSecret("secret-sauce"));
    }

    [TestMethod]
    public void TestSecretsDeletion()
    {
        VaultSecret myVault = new VaultSecret();
        //Assert.AreEqual(myVault.DeletedSecret("Abhishek"), "Abhishek");
        Console.WriteLine(myVault.DeletedSecret("Supriya"));

    }


    [TestMethod]
    public void TestSecretsListAll()
    {
        VaultSecret myVault = new VaultSecret();
        Assert.AreEqual(myVault.ListSecrets,null);
       
    }
}
