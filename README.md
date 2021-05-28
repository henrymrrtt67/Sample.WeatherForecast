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

### Part 4
Part 4 had a small amount of challenge for me, especially whilst using linux alpine, as what during the security scan that is created during this did not pick up any issues, and this is due to the alpine recently solving the issue that was associated, as it required an ignore-check style code inclusion into the pipelines.

The warning given is for ```CVE-2020-28928```, however, any form of CVE is to be worried about as they can range various severities.

However all I had was a warning to include a user for the container, with other smaller, relevant, information that followed.

### Part 5
Part 5 included a lot around healthchecks and making sure that our API endpoints are healthy and easy to reach, and also including that within our own dockerfile so that we can also check our containers work fine alongside it.

It has included 3 seperate changes, two relevant with our local healthchecks within the url, both of which are made within the startup file, and the final within the dockerfile, which passes through the relevant path for these checks to be used by the docker container.

### Part 6
Part 6 was by far the most difficult so far, due to the multiplicity of its path's, inside the dockerfile itself, I was having trouble differentiating the two projects, now including a unit testing project. This trouble was found mostly locally, as, unlike the tutorial I was following, the file did not automatically appear within the unit test project, and was having trouble finding these without a solution.

My solution to this problem was as follows:
- Navigate to File > Preferences > Settings
- Find your way to the extensions drop down, and from there .NET Core Test Explorer
- From here find Test Project Path, and use wildcards (*) to navigate to your csproj file.

From here I had included the powershell scripts provided, however  may go one step further and create a run ps1 file and expand upon that.

The continued expansion of the pipeline surrounding the new paths displayed also deemed easy enough, however, I did have issues with the placement of the unit tests placement in the pipeline, as I was more curious to have the application itself build before running the tests, however, that caused errors within the pipeline, as soon as I moved it to before, it worked correctly, allowing me to place the publishing of the unit tests into the pipeline also.

### Part 7
[![codecov](https://codecov.io/gh/henrymrrtt67/Samples.WeatherForecast/branch/main/graph/badge.svg?token=KZW5MORPPY)](https://codecov.io/gh/henrymrrtt67/Samples.WeatherForecast)


**Am continuing this tomorrow!! Will also edit this to be more in depth, this is my initial tired thoughts!!!**