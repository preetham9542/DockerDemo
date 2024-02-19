# Using Docker for .NET Core Console Application

This guide outlines the steps to create a .NET Core Console Application, Dockerize it, and push the Docker image to Docker Hub.

## Getting Started

Follow these steps to set up and run the project on your local machine.

### Prerequisites

- Visual Studio installed
- Docker installed

### Usage

1. **Create a Console Application:**
   - Use a .NET Core template in Visual Studio to create a console application.

2. **Publish the Docker Image:**
   - Use Solution Explorer to publish the Docker image.

3. **Add Docker Support:**
   - Add Docker support from Solution Explorer.

4. **Build Docker Image:**
   - Open the console application in the terminal or Command Prompt and build the Docker image using the following command:

    ```bash
    # Build Docker image
    docker build -t image-name -f "path of the Dockerfile created using Docker Support (locally)" .
    ```

   Replace "image-name" with your desired image name and provide the correct path to the Dockerfile.

5. **Run the Application in Docker:**
   - Run the application in Docker using the following command:

    ```bash
    # Run Docker application
    docker run -it --rm image-name
    ```

   Replace "image-name" with your Docker image name.

6. **Push Images to Docker:**
   1. **Login to Docker:**

    ```bash
    # Login to Docker
    docker login
    ```

   2. **Tag and Push Docker Image:**

    ```bash
    # Tag and push Docker image
    docker tag image-name username(docker)/image-name
    docker push username(docker)/image-name
    ```

   Replace "image-name" with your Docker image name and "username(docker)" with your Docker username.

Feel free to customize the instructions or add any additional information specific to your project.
