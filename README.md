# My Journey

### Part 1
Managed to run through the first group of instructions simply through following the instructions

Moved the dockerfile and all relevant files into the root file
ran using simple docker calls inside windows terminal powershell

Called using postman call to local host api.

Finding more trouble on the second part whilst trying to make the dockerfile even smaller.

### Part 2
Second part I was exposing 8080 on local dockerfile, whlst I was thinking this was the external port, I did not realise you had to define it through the environment.
My team leader (who had suggested I tried this) had defined this within his own github files, which caused me to realise this.

I now realise that the external port can be changed through the use of <br>
```ENV ASPNETCORE_URLS=http://+:<Port Number>``` <br>
whilst the default port will be 80.
A good, however prehistoric way of finding this out is through the use of running and checking what is mentioned in the terminal once the docker 
container has been run, it will expose the external port within this terminal code.

### Part 3
Part 3 includes the usage of yml pipelines in github with github actions to allow for the creation, building, and publishing of the docker image.

Only one issue came forward with github requiring consent to enable containerisation.

**Am continuing this tomorrow!! Will also edit this to be more in depth, this is my initial tired thoughts!!!**