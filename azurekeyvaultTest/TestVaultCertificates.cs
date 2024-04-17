using azurekeyvault;
namespace azurekeyvaultTest;

[TestClass]
public class TestVaultKeys

{
    

    [TestMethod,Priority(0)]
    public void TestCertificateDownload()
    {
        VaultCertificates myVaultCertificates = new VaultCertificates();
        myVaultCertificates.DownloadCertificate("certImported");
    }

    
}
