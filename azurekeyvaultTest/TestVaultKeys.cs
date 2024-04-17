using azurekeyvault;
namespace azurekeyvaultTest;

[TestClass]
public class TestVaultKeys

{
    [TestMethod,Priority(0)]
    public void TestKeysCreation()
    {
        VaultKeys myVaultKeys = new VaultKeys();
        Console.WriteLine(myVaultKeys.CreateKey("Baby"));
    }

    [TestMethod, Priority(1)]
    public void TestKeyRetrival()
    {
        VaultKeys myVaultKeys = new VaultKeys();
        Console.WriteLine(myVaultKeys.GetKey("Baby"));
    }

    [TestMethod, Priority(2)]
    public void TestKeyDeletion()
    {
        VaultKeys myVaultKeys = new VaultKeys();
        Console.WriteLine(myVaultKeys.DeletedKey("Baby"));

    }


    [TestMethod, Priority(3)]
    public void TestKeyListAll()
    {
        VaultKeys myVaultKeys = new VaultKeys();
        Console.WriteLine(myVaultKeys.ListKeys());

    }
}
