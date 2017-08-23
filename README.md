# SystemWeaver application framework demo

This demo shows how to use our simple application framework. 

There is often a need to throw together a simple SystemWeaver application for a specific task. To make this fast and simple we provide a simple application framework with a login control, so that you can concentrate on creating the needed functionality.

## Building

To build this project you need to get the SystemWeaverClientAPI.dll and put it in the Imported directory.


## How to create your own application

* Create a new WPF Application.
* Add references to 
  * SystemWeaverClientAPI.dll
  * Systemite.SystemWeaver.Controls.dll
* Add an instance of the ApplicationUserControl to the MainWindow

```xml
	<Grid>
		<sw:ApplicationUserControl Name="appControl"
								   ApplicationHeader="SystemWeaver application demo"
								   WelcomeHeader="Welcome!"
								   WelcomeBody="This is an example of how to use the application framework." />
	</Grid>
```
In our demo the name of this custom user control is `ContentUserControl`.

* Create your control, we choose to inherit from `UserControl`.
* Register you control with the framework:
```csharp
  appControl.AddTab("Content", CreateContentControl, true);
```
where `CreateContentControl` is a method that returns the control that you are created.
* The login-control can remember your logins by assigning a `ILoginInfoManager`
```csharp
  appControl.LoginInfoManager = new FileLoginInfoManager("...");
```
You can implement your own `ILoginInfoManager` or use the supplied `FileLoginInfoManager` which stores the login info in a file.
* Build and run. After successful login the factory method will be called and create an instance of your control which will be shown in a tab.

# Note

* This example uses the application framework. If you just want the login functionality, it is contained in its own control.
