# **🚀 Tutorial: Azure Durable Functions – Local Setup & Deployment**

## **📑 Table of Contents**

1. What is Durable Function?

2. Prerequisites

3. Setup Durable Function in Local

4. Run and Test Locally

5. Deploy Durable Function to Azure

6. Verify on Azure

   ---

   ## **1\. What is Durable Function?**

* **Durable Functions** are an extension of **Azure Functions**.

* Enable **stateful workflows** in a **serverless environment**.

* Based on **orchestrator functions** that manage **activity functions**.

**Use Cases:**

* Chaining tasks

* Fan-out / Fan-in

* Human interaction workflows

* Long-running jobs

  ---

  ## **2\. Prerequisites**

Make sure you have installed:

* **.NET SDK** (6/8) → Download

* **Azure Functions Core Tools** → Download

* **Visual Studio Code** \+ Azure Functions extension

1. **Azure Storage Emulator (Azurite)** →

    `npm install -g azurite`  
*   
* An **Azure Subscription**

  ---

  ## **3\. Setup Durable Function in Local**

  ### **Step 1 – Create a New Function Project**

2. `func init DurableFuncDemo --worker-runtime dotnet-isolated`  
3. `cd DurableFuncDemo`  
   

   ### **Step 2 – Install Durable Functions Extension**

4. `dotnet add package Microsoft.Azure.Functions.Worker.Extensions.DurableTask`  
   

   ### **Step 3 – Add Orchestrator, Activity, Client**

   #### **Orchestrator Function**

5. `[Function("OrchestratorFunction")]`  
6. `public static async Task<List<string>> RunOrchestrator(`  
7.     `[OrchestrationTrigger] TaskOrchestrationContext context)`  
8. `{`  
9.     `var outputs = new List<string>();`  
10.     `outputs.Add(await context.CallActivityAsync<string>("SayHello", "Tokyo"));`  
11.     `outputs.Add(await context.CallActivityAsync<string>("SayHello", "Seattle"));`  
12.     `outputs.Add(await context.CallActivityAsync<string>("SayHello", "London"));`  
13.     `return outputs;`  
14. `}`  
    

    #### **Activity Function**

15. `[Function("SayHello")]`  
16. `public static string SayHello([ActivityTrigger] string name, FunctionContext context)`  
17. `{`  
18.     `return $"Hello {name}!";`  
19. `}`  
    

    #### **Client Function (HTTP Starter)**

20. `[Function("HttpStart")]`  
21. `public static async Task<HttpResponseData> HttpStart(`  
22.     `[HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequestData req,`  
23.     `[DurableClient] DurableTaskClient client)`  
24. `{`  
25.     `string instanceId = await client.ScheduleNewOrchestrationInstanceAsync("OrchestratorFunction");`  
26.     `return client.CreateCheckStatusResponse(req, instanceId);`  
27. `}`  
      
    ---

    ## **4\. Run and Test Locally**

28. Start **Azurite** (storage emulator):

     `azurite`  
29.  Default connection string:

     `UseDevelopmentStorage=true`  
1.   
30. Run Function App:

     `func start`  
2.   
3. Open browser → `http://localhost:7071/api/HttpStart`  
    You’ll get JSON response with statusQueryGetUri → poll it to check results.

   ---

   ## **5\. Deploy Durable Function to Azure**

   ### **Step 1 – Login**

31. `az login`  
    

    ### **Step 2 – Create Resource Group**

32. `az group create --name durable-func-rg --location eastus`  
    

    ### **Step 3 – Create Storage Account**

33. `az storage account create --name durablefuncstorage123 --location eastus --resource-group durable-func-rg --sku Standard_LRS`  
    

    ### **Step 4 – Create Function App**

34. `az functionapp create \`  
35.   `--resource-group durable-func-rg \`  
36.   `--consumption-plan-location eastus \`  
37.   `--runtime dotnet-isolated \`  
38.   `--functions-version 4 \`  
39.   `--name DurableFuncDemo123 \`  
40.   `--storage-account durablefuncstorage123`  
    

    ### **Step 5 – Deploy**

41. `func azure functionapp publish DurableFuncDemo123`  
      
    ---

    ## **6\. Verify on Azure**

* Go to **Azure Portal → Function App → DurableFuncDemo123**

* Run `HttpStart` endpoint.

* Check **Monitor** tab for orchestration & activity logs.


