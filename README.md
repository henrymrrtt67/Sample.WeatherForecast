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
[![codecov](https://codecov.io/gh/henrymrrtt67/Sample.WeatherForecast/branch/main/graph/badge.svg?token=IOU2UJH3Z2)](https://codecov.io/gh/henrymrrtt67/Sample.WeatherForecast)

In part 7 I managed to learn more about code coverage, and more importantly, different ways of presenting it. We have used codecov instead as it has a close ties to github, and has some aesthetically pleasing aspects around the code coverage wheel.

as shown above, I have managed to print it out in the readme, and more importantly that it has the code coverage wheel.

The dockerfile was needed changing as it needed a place to output the code coverage, whilst the yaml file pushed it to the codecov url which allowed for the visuals of the code coverage wheel. I also included the final change for the codecov.yml file which uses a infastructure as code (IaS), and allows me to set targets and thresholds for code coverage.

The code coverage also allows for showing in the readme, which is beneficial on many fronts, which is shown at the top of this parts description of my journey.

### Part 8
During this part it was taking advantage of the branch policies available on github, as well as increasing the code coverage percentage in both the expected amount, using codecov.yml, and placing it up to 80%, as well as ignoring all code that was impossible/not necessary to test.

The code coverage was taken up to 94%, which was well above the 80% necessary for the code to pass.

Alongside this, we created a ci (continuous integration) for the pull requests alone, which we then set that it must pass whenever a branch wishes to be merged into the main branch, along with being able to set the amount of people needed to review the code before it is merged.

### Part 9
This part is mostly around static code analysis, and the changing of using codecov to code climate, which allows for more in depth code analysis, and giving visual aids.

Other than this it has just edited the code itself in order to test around, and making sure that correct code was used throughout.

A little bit of an issue arised from the switch, as the code climate wasn't able to find it at the time.

**Am continuing this tomorrow!! Will also edit this to be more in depth, this is my initial tired thoughts!!!**