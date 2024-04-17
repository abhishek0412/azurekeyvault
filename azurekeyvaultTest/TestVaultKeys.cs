using azurekeyvault;
namespace azurekeyvaultTest;

[TestClass]
public class TestVaultKeys

{
    string name = EmptyClass.getName();

    [TestMethod,Priority(0)]
    public void TestKeysCreation()
    {
        VaultKeys myVaultKeys = new VaultKeys();
        Console.WriteLine(myVaultKeys.CreateKey(name));
    }

    [TestMethod, Priority(1)]
    public void TestKeyRetrival()
    {
        VaultKeys myVaultKeys = new VaultKeys();
        Console.WriteLine(myVaultKeys.GetKey(name));
    }

    [TestMethod, Priority(2)]
    public void TestKeyDeletion()
    {
        VaultKeys myVaultKeys = new VaultKeys();
        Console.WriteLine(myVaultKeys.DeletedKey(name));

    }


    [TestMethod, Priority(3)]
    public void TestKeyListAll()
    {
        VaultKeys myVaultKeys = new VaultKeys();
        Console.WriteLine(myVaultKeys.ListKeys());

    }
}
