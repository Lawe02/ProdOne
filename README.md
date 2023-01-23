# ProdOne
#This project Contains a ShapeCalculator where you can add 4 different shapes#

#This project Contains a Calculator where you can perform 6 different operations#

#This project Contains a Rock Paper Sicors engine where you can play against#

#Both Shape and calculator support crud operations#

#Rock Paper Sicors game results are saved and can't be edited, winrate is avilable to se#

##The shape calculator saves its entities as Shape that contains createdate, area, circumference and actual shape(form). Shape also is a baseclass for the different shapes, the reason for that is because all shapes have different properties for counting area and circumference.##

##Every different operation in the calculator is part of the same interface where they have in common is that they return an object that contains result, operand a and b, createdate and the name of the operation. ##

##Since no Service directly have acces to the applicationdbcontext they all return objects that gets handled in the menu class. The menu class uses dependecy injection to get acces to isntance data and the database.##
