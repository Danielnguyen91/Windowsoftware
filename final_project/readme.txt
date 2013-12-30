Name: Toan Nguyen
Csci 351
Final Project
Visual Studio: 2010

The Data structure to create the Path and cross the river is:

I divided the map into four region 
4,8,9,10,11,7,6,5 is in region 1
12,13,14,15 is in region 2
1,2 in in region 3
3 is in region 4

Then I check the current coordinate  x and y to see if the icon is above the river or below the river by get the coordinate of x and y of map 
when moving icon to the map, the selection dialog appear to allow you choose up to four location, after choosing locations
the program will check if the location of icon is reach the destination,if not:
**Data structure to move the icon**
Calculate the angle (direction) between the icon location and destination,
Math.Atan2(destination.Y - yicon, destination.X - xicon) * 180 / Math.PI) then 
x icon coordinate += speed * Cos(direction)
y icon coordinate += speed * sin(direction)
This function is move the icon to same direction of destination with a constant speed
then I check if x coordinate of icon is equal x destionation and y coordinate bigger or smaller than y destination ,if yes 
I increase or decrease the y coordinate to move the icon to destination
then I check if y coordinate of icon is equal y destionation and x coordinate bigger or smaller than x destination ,if yes 
I increase or decrease the x coordinate to move the icon to destination

**Data Structure to cross the river**
if icon and destination is in different region, I calculate the distance between the current icon location to one side of 5 bridge
then I compare the shortest distance between them, then icon is choose the shortest distance to move to the one side of the bridge
and then the icon is move to the other side of the bridge and continue to move to reach its destination.
similliar, I also do the same with other side of river to find the shortest distance between the icon to the bridge and use this distance
to move the icon to the bridge and then cross the bridge and continue
When moving the icon, I will check the current icon location to see if it is above or below the river, and keep the track the location to see
if it is in region 1,2,3,4. if it is in region 3, I will use the bridge d to reach location, and if it is in the region 4, I will use the bridge e 
to reach its location

if the icon is reach its destination, it will check if any destination in the list, if yes continue to move to different location,
if not set the new coordinate as its coordinate.


The moving is fully implement in the first two icons