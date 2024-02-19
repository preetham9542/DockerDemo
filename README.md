Here's the way i have used the docker and some commands
1.Create a console Application using a .Net Core Template in Visual Studio
2.Publish the docker using solution explorer
3.Then Add the Docker Support from Solution Explorer
4.Open th console Application in terminal & by using Command Prompt build an image using the command
<span style="background-color: lightblue">docker build -t image-name -f "path of the docker file created using Docker Support (locally)" .</span>
