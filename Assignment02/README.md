# Assignment 2 - Add Dapr Service invocation

In this assignment, you're going to add Dapr into the mix. You will use the **Service invocation** building-block.

## Dapr Service invocation building block

In a microservices application, it is important to be able to communicate with other services without knowing where they live. Especially when the services are running in Kubernetes (or some other orchestration platform), services can be moved around and replaced with a new version all the time. This is where the Dapr service-to-service building block comes in. It works like this:

![](img/service-invocation.png)

1. Service A makes an HTTP or gRPC call meant for Service B.  The call goes to Service A's Dapr sidecar.
2. Dapr discovers Service B's location using its name-resolution component for the hosting environment the solution is running in. 
3. Service A's sidecar forwards the message to Service B's Dapr sidecar.
4. Service B's Dapr sidecar forwards the request to Service B.  Service B performs its corresponding business logic.
5. Service B returns a response for Service A to its sidecar.
6. Dapr forwards the response to Service A's Dapr sidecar.
7. Service A's sidecar forwards the response to Service A.

For this hands-on assignment, this is all you need to know about this building-block. 

> The building block offers way more features like security and load-balancing. Check out the Dapr documentation later for learning all about these additional features.

## Assignment goals

In order to complete this assignment, the following goals must be met:

- The VehicleRegistrationService is started running Dapr.
- The TrafficControl service uses the Dapr client for .NET to call the GetVehicleInfo method on the Government service using a Dapr direct service-to-service invocation.

## DIY instructions

First open the `Assignment 2` folder in this repo in VS Code. Then open the [Dapr documentation](https://github.com/dapr/docs) and start hacking away. Make sure the Government service is using `50001` as the dapr-grpc-port. If you need any hints, you may peek in the step-by-step part.

## Step by step instructions

To get step-by-step instructions to achieve the goals, open the [step-by-step instructions](step-by-step.md).

## Next assignment

Make sure you stop all running processes before proceeding to the next assignment.

Go to [assignment 3](../Assignment03/README.md).