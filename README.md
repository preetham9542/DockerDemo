# Project Title

Brief description of your project.

## Getting Started

These instructions will help you set up and run the project on your local machine.

### Prerequisites

- Visual Studio installed
- Docker installed

### Installation

1. Create a console application using a .NET Core template in Visual Studio.
2. Publish the Docker image using Solution Explorer.
3. Add Docker support from Solution Explorer.

### Building Docker Image

Open the console application in the terminal or Command Prompt and build the Docker image using the following command:

```bash
docker build -t image-name -f "path of the Dockerfile created using Docker Support (locally)" .
