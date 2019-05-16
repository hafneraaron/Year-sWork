body{
	width: 80%;
	padding: 10px 10px;
	margin: 10px auto;
	font-family: Georgia, serif;
	font-size: 15pt;
	background-color: rgb(209, 252, 174);
	height: -500px;
}

header{
	background-color: rgb(32, 81, 23);
	padding-left: 10px;
	padding-bottom: 10px;
	padding-top: 10px;
	padding-right: 10px;
	text-align: right;
	color: rgb(248, 255, 247);
}

header h1{
	background-color: rgb(32, 81, 23);
	font-size: 30pt;
	font-family: Helvetica, sans-serif;
	transform: translate(-230px, 0px);
	display: inline-block;
	margin-left: 3px;
	margin-bottom: 3px;
	margin-top: 3px;
	margin-right: 3px;
}

header h2{
	background-color: rgb(32, 81, 23);
	display: inline;
	font-family: Helvetica, sans-serif;
	vertical-align: bottom;
	font-size: 20pt;
}

nav{
	float: right;
	background-color: green;
	width: 250px;
	height: 340px;
	margin-bottom: 7px;
	margin-top: 7px;
	padding-top: 10px;
}

nav a{
	padding-left: 10px;
}

#info{
	float: left;
	background-color: green;
	width: 250px;
	height: 350px;
	margin-bottom: 7px;
	margin-top: 7px;
	color: rgb(248, 255, 247);
}

section#info p{
	text-align: center;
	font-size: 17pt;
	padding-left: 10px;
	padding-right: 10px;
}

#main{
	transform: translate(-25px, -80px) scale(0.45);
	height:300px;
}

aside{
	font-size: 200%;
	position: absolute;
	top: 250px;
	left: -550px;
	width: 470px;
	padding: 0;
	display: none;
	color: rgb(248, 255, 247);
}

p:hover + aside{
	display: block;
}

section#main p{
	background-color: rgb(148, 170, 145);
	padding-top: 50px;
	margin: 5px auto;
	text-align: center;
	font-size: 150%;
}

p#patio{
	width: 300px;
	height: 250px;
}

p#kitchen{
	width: 150px;
	height: 175px;
	float: left;
	transform: translate(107px, -125px);
}

p#dr{
	width: 150px;
	height: 180px;
	float: left;
	transform: translate(-43px, -360px);
}

p#br1{
	width: 150px;
	height: 100px;
	float: right;
	transform: translate(-107px, -275px);
}

p#lr{
	width: 550px;
	height: 300px;
}

img[alt]{
	transform: scale(0.3);
	position: absolute;
	top:400px;
	right: 460px;
	display: none;
}

p:hover + aside + img{
	display: block;
}

p#ipr{
	width: 800px;
	height: 850px;
	transform: translate(124px, 0px);
}

p#ipr span{
	transform: translate(30px,0px);
}

#main p#pool{
	background-color: blue;
	border-radius: 15px;
	height: 795px;
	width: 330px;
	transform: translate(-90px, -875px);
}

#main p#pool2{
	background-color: blue;
	border-radius: 15px;
	height: 400px;
	width: 400px;
	transform: translate(250px, -1330px);
}

#main p#ht{
	background-color: blue;
	border-radius: 100px;
	height: 200px;
	width: 200px;
	transform: translate(250px, -2077px);
}

#bottom{
	float:left;
	transform: translate(0px, -180px);
}

footer{
	background-color: rgb(32, 81, 23);
	text-align: right;
	padding-bottom: 8px;
	padding-top: 8px;
	color: rgb(248, 255, 247);
	transform: translate(0px, 600px);
}