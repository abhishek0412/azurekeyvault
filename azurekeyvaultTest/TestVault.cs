using azurekeyvault;
namespace azurekeyvaultTest;

[TestClass]
public class TestVault

{
    [TestMethod]
    public void TestSecretsCreation()
    {
        Vault myVault = new Vault();
        //Assert.AreEqual(myVault.CreateSecret("Abhishek", "Choudhary"), "Abhishek");
        Console.WriteLine(myVault.CreateSecret("Supriya", "Choudhary"));
    }

    [TestMethod]
    public void TestSecretsRetrival()
    {
        Vault myVault = new Vault();
        //Assert.AreEqual(myVault.GetSecret("Abhishek"), "Abhishek");
        Console.WriteLine(myVault.GetSecret("secret-sauce"));
    }

    [TestMethod]
    public void TestSecretsDeletion()
    {
        Vault myVault = new Vault();
        //Assert.AreEqual(myVault.DeletedSecret("Abhishek"), "Abhishek");
        Console.WriteLine(myVault.DeletedSecret("Supriya"));

    }


    [TestMethod]
    public void TestSecretsListAll()
    {
        Vault myVault = new Vault();
        Assert.AreEqual(myVault.ListSecrets,null);
       
    }
}
