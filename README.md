Our Goal
We know we need to implement a display and then have the WeatherData update that display each time it has new values, or, in other words, each time the measurementsChanged() method is called. But how? Let’s think through what we’re trying to acheive

* We know the WeatherData class has getter methods for three measurement values: temperature, humidity, and barometric pressure.
● We know the measurementsChanged() method is called anytime new weather measurement data is available. (Again, we don’t know or care how this method is called; we just know that it is called.)
● We’ll need to implement three display elements that use the weather data: a current conditions display, a statistics display,and a forecast display. These displays must be updated as often as the WeatherData has new measurements.
● To update the displays, we’ll add code to the measurementsChanged() method.

ReadMore in this book 

Head First Design Patterns, 2nd Edition by Elisabeth Robson, Eric Freeman-O'Reilly

** PAGE 37 **
