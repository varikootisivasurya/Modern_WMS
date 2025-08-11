# ModernWMS - Warehouse Management System

<div align="center">
  <img src="logo.png" alt="ModernWMS logo" width="200" height="auto" />
  <h1>ModernWMS</h1>
 
</div>

# Contents

- [ModernWMS - Warehouse Management System](#modernwms---warehouse-management-system)
- [Contents](#contents)
  - [Introduction](#introduction)
  - [Requirements](#requirements)
    - [Windows OS](#windows-os)
  - [Installation](#installation)
    - [Windows](#windows)
    - [Docker(Optional)](#dockeroptional)
  - [Usage](#usage)
 

## Introduction 

  The inventory management system is a set of small logistics warehousing supply chain processes that we have summarized from years of ERP system research and development. In the process of work, many of our small and medium-sized enterprises, due to limited IT budget, cannot use the right system for them, but there are real needs in warehouse management, that's how we started the project. To help some people who need it.

## Requirements



### Windows OS

+ Windows 10(1607+),11(21H2+)
+ Windows Server 2012+

## Installation


### Windows

+ download the source code and compile
  + Step 1, download the source code
  ```PowerShell
  cd C:\
  wget -Uri https://gitee.com/modernwms/ModernWMS/repository/archive/master.zip  -OutFile master.zip
  Expand-Archive -Path C:\master.zip -DestinationPath C:\
  ```
  + Step 2, Install .NET SDK and NodeJS
  ```CMD
  wget -Uri https://download.visualstudio.microsoft.com/download/pr/35660869-0942-4c5d-8692-6e0d4040137a/4921a36b578d8358dac4c27598519832/dotnet-sdk-7.0.101-win-x64.exe  -OutFile dotnet-sdk-7.0.101-win-x64.exe
  .\dotnet-sdk-7.0.101-win-x64.exe /install /quiet /norestart
  wget -Uri https://nodejs.org/dist/v16.13.1/node-v16.13.1-x64.msi  -OutFile node-v16.13.1-x64.msi
  msiexec /i .\node-v16.13.1-x64.msi /passive /norestart
  npm install -g yarn
  ```
  + Step 3, compile frontend and backend
  ```
  md C:\ModernWMS\frontend\
  md C:\ModernWMS\backend\
  cd C:\ModernWMS-master\backend
  dotnet publish 
  copy-item -path "C:\ModernWMS-master\backend\ModernWMS\bin\Debug\net7.0\publish\*" -destination "C:\ModernWMS\backend\" -recurse
  copy-Item "C:\ModernWMS-master\backend\ModernWMS\wms.db" -Destination "C:\ModernWMS\backend\"
  cd C:\ModernWMS-master\frontend  
  yarn
  yarn build 
  copy-item -path "C:\ModernWMS-master\frontend\dist\*" -destination "C:\ModernWMS\frontend\" -recurse
  ```
  + Step 4, Install Nginx
  ```
  cd C:\
  wget -Uri http://nginx.org/download/nginx-1.16.1.zip -OutFile nginx-1.16.1.zip
  Expand-Archive -Path C:\nginx-1.16.1.zip -DestinationPath C:\
  copy-item -path "C:\ModernWMS\frontend\*" -destination "C:\nginx-1.16.1\html\" -recurse
  cd C:\nginx-1.16.1\
  start nginx.exe
  cd C:\ModernWMS\backend\
  dotnet ModernWMS.dll --urls http://0.0.0.0:20011
  ```

### Docker(Optional)

+ Approach 1, download the image from docker hub

  + Step 1, install docker and download the image

  ```bash
  sudo apt install docker.io
  sudo docker pull modernwms/modernwms:1.0
  ```  

  + Step 2，deploy
  
  ```bash
  sudo docker run -d -p 20011:20011 -p 80:80  modernwms/modernwms:1.0 ./run.sh
  sudo docker ps -a | awk 'NR>1 && $2=="modernwms/modernwms:1.0" {print $1}'
  sudo docker exec -it <CONTAINER ID> /bin/bash
  ```

  After entering the Docker container, execute the following command in the container.

  ```bash
  grep -rl "http://127.0.0.1:20011" /frontend | xargs sed -i 's#http://127.0.0.1:20011#http://IP address:20011#g'
  exit
  ```

  restart container

  ```bash
  sudo docker restart <CONTAINER ID>
  ```

+ Approach 2, Build your own image
  + Step 1, download the source code

  ```bash
  cd /tmp/ && wget https://gitee.com/modernwms/ModernWMS/repository/archive/master.zip
  ```  

  + Step 2，Install .NET SDK and NodeJS

  ```bash
  wget https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
  sudo dpkg -i packages-microsoft-prod.deb
  sudo apt-get update && sudo apt-get install -y dotnet-sdk-7.0
  curl -fsSL https://deb.nodesource.com/setup_16.x | sudo -E bash -
  sudo apt install -y nodejs
  sudo apt-get install gcc g++ make
  sudo npm install -g yarn
  ```  

  + Step 3, compile frontend and backend
  
  ```bash
  sudo apt install unzip
  cd /tmp/ && unzip master.zip && cd ./ModernWMS-master
  cd /tmp/ModernWMS-master/frontend/ && sed -i 's#http://127.0.0.1#http://IP address#g' ./.env.production
  yarn && yarn build && cp -rf /tmp/ModernWMS-master/frontend/dist/* /tmp/ModernWMS-master/docker/frontend/
  cd /tmp/ModernWMS-master/backend/ && sudo dotnet publish && cp -rf /tmp/ModernWMS-master/backend/ModernWMS/bin/Debug/net7.0/publish/* /tmp/ModernWMS-master/docker/backend/
  cp -rf /tmp/ModernWMS-master/backend/ModernWMS/wms.db /tmp/ModernWMS-master/docker/backend/
  ``` 

  + Step 4, deploy

  ```bash
  sudo apt install docker.io
  cd /tmp/ModernWMS-master/docker/
  docker build -t modernwms:1.0 .
  docker run -d -p 20011:20011 -p 80:80  modernwms:1.0 ./run.sh
  ```

## Usage

  ```shell
  Accessing ip address (http://127.0.0.1 or http://the IP address you depolyed) via web browser 
  
  Account: admin 
  Password: 1
  ```

  <h4>
    <a href="https://wmsonline.ikeyly.com">Demo</a>
  </h4> 

  <img src="image2.png" alt="image2" height="auto" />

  <img src="image0.png" alt="image0" height="auto" />

  <img src="image1.png" alt="image1" height="auto" />
  
