using azurekeyvault;
namespace azurekeyvaultTest;

[TestClass]
public class TestVaultKeys

{
    static string name = EmptyClass.getName();

    [TestMethod,Priority(0)]
    public void TestKeysCreation()
    {
        VaultKeys myVaultKeys = new VaultKeys();
        Console.WriteLine(myVaultKeys.CreateKey(TestVaultKeys.name));
    }

    [TestMethod, Priority(1)]
    public void TestKeyRetrival()
    {
        VaultKeys myVaultKeys = new VaultKeys();
        Console.WriteLine(myVaultKeys.GetKey(TestVaultKeys.name));
    }

    [TestMethod, Priority(2)]
    public void TestKeyDeletion()
    {
        VaultKeys myVaultKeys = new VaultKeys();
        Console.WriteLine(myVaultKeys.DeletedKey(TestVaultKeys.name));

    }


    [TestMethod, Priority(3)]
    public void TestKeyListAll()
    {
        VaultKeys myVaultKeys = new VaultKeys();
        Console.WriteLine(myVaultKeys.ListKeys());

    }
}
