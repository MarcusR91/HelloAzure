namespace HelloAzureApi.TEST;
using HelloAzureApi.Controllers;

public class UnitTest1
{

    NameController controller = new NameController();


    [Fact]
    public void GetMyName()
    {
        var returnValue = controller.GetName(1);
        Assert.Equal("Marcus Rosberg", returnValue.Value);
    }


    [Fact]
    public void Test1()
    {

    }
}