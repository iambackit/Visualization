# Table of contents
* [Introduction](#introduction)
* [How it works](#howitworks)
* [Product](#product)

## Introduction
The project was made in **Unity 2020.1.3f1**. To open the project, find the **SampleScene.unity** in the **Assets/Scenes** folder and open it.

The goal of this project is to **visualize sorting algorithms**, at the moment it contains 4 which are:
- selection sorting
- bubble sorting
- comb sorting
- merge sorting

There are 4 kinds of **data randomization methods**, which are:
- random
- sorted
- almost sorted
- reversed

## How it works
If you run the software, you can **change the order of the data** by clicking the button under the **'Shuffle' text** and you can switch between the shuffle methods by clicking on the arrows.
You can **change the algorithms** as well with the arrows under the **'Algorithm' text**.
You can set **2 main colors** for the circles, which are settable. (Do not run the software while change this because you lose your modifications. Set up the colors, then run the software. If you want to change the colors, then stop the software, change the colors and run again. You can change the color in Unity by find **'Main Camera'** object the in the **'hierarchy'** tab and change the **'Start'** and **'End' colors/fields** on the **'Controller' script**).
The software calculates the **gradient** between those colors and will set up the circles. If you shuffle the data, the **circles' position and its size** (relatively to its original position) will change.
If you click on the **'Start'** button, the choosen algorithm starts to order the circles.

## Product
![](https://github.com/iambackit/Visualization/blob/master/imgs/gui0.png)
![](https://github.com/iambackit/Visualization/blob/master/imgs/gui1.png)
