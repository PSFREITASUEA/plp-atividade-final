public class Main {

    public static void main(String[] args) {

        WeatherData weatherData = new WeatherData();
        CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);

        weatherData.setMeasurements(30,65,30.4F);
        weatherData.setMeasurements(34,70,29.2F);
        weatherData.setMeasurements(29,90,29.2F);


    }
}

