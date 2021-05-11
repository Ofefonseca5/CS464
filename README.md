# CS464 Term Project: Human Perspective on Ethical Dilemmas in Artificial Intelligence Systems
### Team Members: Daiana Bilbao, Ofe Fonseca, Maddie Watts
### Software: 3D Unity Project, WebGL
### Project Goal: To crowdsource human opinions/data on ethical dilemmas faced by AI Systems in the context of Self-Driving Cars and in the Medical Field for improving decision making in AI Systems.
# External Links
### Research Paper (Overleaf Link): https://www.overleaf.com/read/fjwvnzjvtbbm
### Video Demo (Youtube): https://www.youtube.com/watch?v=X5OQx1t0yG8
### Code Explaination (Youtube): https://youtu.be/U8unVhbuIBU
### Try It: https://play.unity.com/mg/other/webgl-builds-48719
### Project Website: None 

# Overview
For our Term Project we decided we wanted to create an experiment using Unity and wanted to explore ethical dilemmas in artificial intelligence, not only with self-driving cars but in other scenarios as well. The correct ethics is what a group of people consider to be the correct thing to do in an ethical dilemmas so in an attempt to find solutions to ethical dilemmas we decided on making an experiment that would crowdsource human opinions on varying ethical dilemmas. 

# Experiment Design

### Browser Experience 
We wanted to make each scenario was realistic as possible which is why we decided to create a 3D Unity Project. However, since most don't have access to their own Virtual Reality headset, it wasn't feasible to just make our project in 3D so we have decided to make 'browser mode' our primary mode. It was not a big deal because Unity has provided us with other elements that would make our scenarios as realistic as possible such as displaying images, audio and adding a timer. The browser experience also allowed anyone with access to a desktop browser to participate in our experiment which was a huge plus!

### Scenario Design
Each scenario included an image with an acompanying audio. Each scenario was also timed for 45 seconds. Participants had 45 seconds to listen to each audio (which explained the scenario) and to make a decision. We decided to make it timed because in a real-life situation, you do not have a lot of time to make a sacrificing decision so we added the timer to make the sceanarios realistic. Also, studies show that adding time-pressure to decision-making make people be more honest with their decision-making. 

#### Sceanario 1
The first sceanario tests the participant's preference on sacrificing the younger or older generations in the context of a building fire. 

#### Sceanario 2
The second scenario tests the participant's preference on sacrificing the younger (the mother is carrying a *young* child) or older generation in the context of a road catastrophe. It also tests for the participant's preference on societal status. A mother vs. a United States Veteran. Lastly, it test whether a participant favors saving one life vs saving many lives.

#### Sceanario 3
The thid scenario tests the participant's preference in a hospital setting. If the participant were to be an artificially intelligent doctor, would they give a patient a painful treatment given that the patient will live a longer life or give the patient a painless treatment given that the participant will die sooner. 

### Surveys
We have also added several types of surveys throughout our experiment. Before each participant begins, we ask demographic information so that we can get an idea of our sample in the end so that we may know if our data is skewed towards a certain demographic. The goal is to have a very diverse demographic so that the results can be generalizable. Then, after each scenario, a series of question are asked about the given scenario. The goal is to collect the opinions of humans so the questionnaires after each scenario helped us accomplish that goal.

### Data Collection 
To collect data on decision making choices we are using UnityWebRequest to Post responses to an existing Google Form. This feature allowed us to collect all necessary data about each participant so that we may later analyze it.

# Results

#### Demographics Summary 
##### Age
![base](/Experiment-Results-Summary/Age.png)
##### Ethnicity
![base](/Experiment-Results-Summary/Ethnicity.png)
##### Gender
![base](/Experiment-Results-Summary/Gender.png)
##### Education
![base](/Experiment-Results-Summary/Education.png)
##### Experiment Mode
![base](/Experiment-Results-Summary/Experiment-Mode.png)
#### Scenario 1 Summary
##### Participant Decision Summary
![base](/Experiment-Results-Summary/Scenario-1-Decision.png)
##### More Time?
![base](/Experiment-Results-Summary/Scenario-1-More-Time-Result.png)
##### Most Influential Factor
![base](/Experiment-Results-Summary/Scenario-1-Most-Influential-Factors.png)
#### Scenario 2 Summary
##### Participant Decision Summary (Option 1 = Run over the mother w/ a child, Option 2 = Run over the U.S. Veteran)
![base](/Experiment-Results-Summary/Scenario-2-Decision.png)
##### More Time?
![base](/Experiment-Results-Summary/Scenario-2-More-Time-Results.png)
##### Most Influential Factor 
![base](/Experiment-Results-Summary/Scenario-2-Most-Influential-Factors.png)
#### Scenario 3 Summary
##### Participant Decision Summary (Option 1 = decrease lifespan, painless treatment - Option 2 = increase lifespan, painful treatment)
![base](/Experiment-Results-Summary/Scenario-3-Decision.png)
##### How Would Prefer to "go"?
![base](/Experiment-Results-Summary/Scenario-3-How-Would-You-Prefer-To-Go.png)
##### More Time?
![base](/Experiment-Results-Summary/Scenario-3-More-Time-Results.png)
##### If you were offered a risk procedure with a 1% chance of survival, would you do it?
###### Note: The question was rephrased to the question above instead of the one shown in the form. 
![base](Experiment-Results-Summary/Scenario-3-Risky%20Procedure.png)

# Discussion
We think that the scenarios could've been better by making them more difficult to answer. However, we still found the results to be intriguing. Most research surrounding ethical decision making in A.I. Systems is focused on self-driving cars. Our chose to venture outside the context of self-driving cars so that we could see if preferences would be different in varying contexts. We thought that the results would be what we expected however, our results were completely unexpected.

### Participants
For our experiment, we had a total of 10 participants. The majority of our participants were between the ages of 18-24, Hispanic Latino or Spanish Origin, had a Bachelors Degree, and 100% of them chose to do this experiment in browser mode. 5 of the participants picked Male as their Gender & the remaining 5 participants picked Female as their Gender. Based on these results, we concluded that our pool of participants is not very diverse and that the results are skewed. 

### Scenario 1
For the first scenario, 80% of participants decided to save the baby in a stroller instead of the unconcious man. We expected for participants to favor younger/healthy lives more. The unconcious man had a low survival rate while the baby was completely fine and healthy. The baby also has a longer life to live. However, for 50 % of the responses, the time pressure was the most influential factor to their decision. 20% would change their answer if they had more time to think about. These results support what we expected because humans aren't as quick to make a decision as a machine is. Therefore, we see a support for ethics research because this data could be taught to an aritifically intelligent system to make these decision automatically.  

### Scenario 2
For the second scenario, was a little unexpected because we expected the percentage for running over the U.S. veteran to be higher than 60%. However, 60% is still pretty high. 100% of participants would not change their answer if they had more time. 70% of participants picked that saving more lives was most important to them in this scenario. This is consistent with other studies out there, which says that people favor saving more lives over saving one. This also supports that most people have a utilitarian mindset. 20% picked that saving a baby mattered the most. Lastly, 10% picked that saving young lives mattered the most. These results are consistent with the results from the first sceanario. So far, we are seeing preferences for young, healthy, and abundance. 

### Scenario 3
The third scenario, the results were fairly unexpected because we had expected for painful/increased lifespan to be the most popular answer but most prefer a painless treatment/decreased lifespan. We thought that an increased lifespan would win over comfort. 60% of participants would choose decreasing the lifespan of the patient given that their medical treatment would be painless. We then asked, if the participants themselves, were the patients, what would they prefer? Overwhelmingly, 90% prefer a short life and painless death over a long life and painful death. What we found intresting, is that the results were different depending on the role of the participant (A.I. Doctor vs. Patient). They weren't completely different but 40% of the participants as A.I. doctors picked increasing the patient's lifespan/painful treatment while only 10% picked increasing lifespan/painful treatment if they were the patient. This provides insights that participant's treat others better than they treat themselves. An A.I. system has no emotion so they would only treat a patient, how they would like to be treated without their emotions getting in the way. This provides support for advancing A.I. systems to make these decisions automatically, efficiently, and rationally. 
90% would not change their decision if they had more time. Lastly, we asked participants if they would undergo a risky procedure given that there's only a 1% chance of survival. 70% answered "No". This gives an indication of when an A.I. doctor should give up on saving a partient. 

### Things we missed
When finding participants, we did not check the participant's knowledge of Artificially Intelligent Systems. For some participant's we noticed that there was some confusion in the scenarios so this may have lead to inaccurate results. Since this experiment was completely remote and voluntary, the internal validity isn't the best because we don't know whether some participants just clicked through our experiment randomly so this could mean some results are invalid. However, a pro could be that the external validity is very high because this experiment was done in the comfort of the participant's home where there's no pressure or judgement present. Each participant is also anonymous since we don't ask for unique information such as name, phone or email. 

# Conclusion
We learned that there are a multitude of ethical dilemmas that A.I. systems need to be prepared for. We have only scratched the surface of scenarios. To advance A.I. systems, then human input is crucial. We think differently than a machine does. Therefore, it is important to teach it our values and beliefs. Throughout this experiment, we learned a lot about humans an were able to find some key trends in human ethics. For example, there's a preference for saving younger generations, healthier individuals, saving many lives over saving only one life, and lastly, there's a huge preference of choosing comfort when deciding medicial treatments. These were insights which we did not expect to find and we learned a lot about ourselves. 
