using TDDSI.AGRICULTURA.BACKEND.Domain.WeatherForecasts;

namespace TDDSI.AGRICULTURA.BACKEND.Domain.Tests;
[TestClass]
public class WeatherForecastServiceTests {

    [TestMethod]
    public void WeatherForecastList_Success() {
        //Arrange

        //Act
        var result = WeatherForecastService.WeatherForecastList();

        //Assert
        Assert.IsNotNull( result );
    }
}
