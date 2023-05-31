# AssurityCodingTest
Repository for the Coding Test.

## Prerequisites
Programing Language: **C#** <br />
Integrated Development Environment (IDE): **Visual Studio Community 2022** <br />
Targeting .NET Framework: **.NET 6.0** <br />

## Getting Started
### Clone the Repository
1. Copy the **HTTPS** web url in the github repository. <br />
2. In Visual Studio's menu bar, choose **Git > Clone Repository**. <br />
3. Paste in the HTTPS web url and specify the target Path. <br />
4. Click Clone. <br />

### Building the Solution
1. Once the Cloning is done, open the **SampleAPIAutomationTest.sln**. You will then be navigated to the Solution Explorer Tab. <br />
2. To ensure the Nuget Packages are installed correcty, right click the Solution and choose **Restore NuGet Packages**. <br />
3. To Build the Solution, right click the Solution and choose **Build Solution**. <br />
4. Build should succeed. <br />

### Test Explorer
1. In case that the Test Explorer is not visible in the IDE, in the menu, click on **Test > Test Explorer** <br />
![image](https://github.com/CarlCapitanHub/AssurityCodingTest/assets/135119145/819f8bc5-9be5-4ee1-8dff-ddace0e6ecf4)

2. You should now be able to view the test/s available in the Solution. <br />
![image](https://github.com/CarlCapitanHub/AssurityCodingTest/assets/135119145/c2ccdbb2-f9b7-4a27-9516-9469455a3d16)

### Test Execution
1. Select the CategoryTest and right click Run. <br />
![image](https://github.com/CarlCapitanHub/AssurityCodingTest/assets/135119145/b8f44348-59e6-40ea-9f72-c7b7fdcf6097)

2. Test should now run and results should be displayed in the **Test Detail Summary.** <br />
![image](https://github.com/CarlCapitanHub/AssurityCodingTest/assets/135119145/1688c224-8609-449f-a300-94f2296890d6)

## Libraries Utilized:
#### Http Client Library .NET: **RestSharp**
#### Test Framework .NET: **MS Test**

## Execution via GitHub Workflows
You can also execute the test by manually triggering the github workflow setup.

1. In the GitHub Repo, click on Actions.
2. Under All Workflows, select the **Second .NET Option.** <br />
![image](https://github.com/CarlCapitanHub/AssurityCodingTest/assets/135119145/94633338-ad80-414c-96b6-50283ae1b45e)

3. Click on Run Workflow.
4. Leave the default values for Branch and Log Level.
5. Choose **Test Environment** as the Environment. <br />
![image](https://github.com/CarlCapitanHub/AssurityCodingTest/assets/135119145/63f6f0ad-2649-42bc-84eb-d15e1f8ad812)

6. Click Run Workflow. The manually triggered workflow must now be in queue.

### Viewing the Test Result
1. Once the build is complete, click on the workflow executed. <br />
![image](https://github.com/CarlCapitanHub/AssurityCodingTest/assets/135119145/0c15b480-da52-40db-87ac-8d8c696049f8)

2. Click on Build. <br />
![image](https://github.com/CarlCapitanHub/AssurityCodingTest/assets/135119145/c1c7499d-9200-4cdc-8aa7-48fd1e375cef)

3. You can now view the logs of build. Expand the Test Part of the Log. <br />
![image](https://github.com/CarlCapitanHub/AssurityCodingTest/assets/135119145/d2570e5e-dbcc-4ba2-9e34-8fdad54ed200)


## Author: **Carl Jan Capitan**
