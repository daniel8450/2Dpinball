function preload(){
guy[i] = new Walker("SpelunkyGuy.png", random(40, 600), random(400), random[i]);

}

function draw(){
	background(0, 128, 0);

	for(var i = 0; i < count; i++){
		guy[i].draw();
	}
}

function keyPressed(){
	
	
}

function Walker(ImageName, x, y, moving){
this.spritesheet = loadImage(imageName);
this.frame = 0;
this.x = x;
this.y = y;
this.moving = moving;
this.facing = facing;


this.draw = function();{
	push();

	translate(this.x, this.y);
	if(this.facing < 0){
		scale(-1.0, 1,0);
	}
}

if(this.moving = 0){
	image(this.spritesheet, 0, 0, 80, 80,0,0,80,80)
}else{
	image(this.spritesheet, 0, 0, 80, 80, (this.frame + 1) * 80, 0, 80, 80);

	//if(frame = 0)
	//image(spritesheet)
	//if(frame = 1)
	//image(spritesheet)

	if(this.frameCount % 4 == 0){
		this.frame = (this.frame + 1) % 8
		x = x + 6 * this.moving;
	}
	//if(frameCount % 4 == 0){
	//	this.frame = (this.frame + 1) % 8;
	//	this.x = this.x + 6 + this.moving;


	}



}

pop();

}

this.stop = function(){
	this.moving = 0;
	this.frame = 3;
}

this.go = function(direction){
	this.moving = direction;
	this.facing = direction;
}


//first class///////////////////////
var spritesheet;
var frame = 0;
var x = 50;
var y = 100;
var moving = 0;
var facing = 0;

preload(){
	spritesheet = loadImage("");
}

setup(){
	createCanvas(640,480);
	imageMode(Center);
}

if(keyCode = RIGHT_ARROW){
facing = 0;
moving = 1;
}


draw(){
translate(x,y)

if(moving = 0){
	image(spritesheet, 0, 0, 80, 80,0,0,80,80)
}else{
	image(spritesheet, 0, 0, 80, 80, (this.frame + 1) * 80, 0, 80, 80);
	//if(frame = 0)
	//image(spritesheet,0, 0, 80, 80, 80, 0, 80, 80)
	//if(frame = 1)
	//image(spritesheet,0 ,0, 80, 80, 160, 0, 80, 80)
	//if(frame = 2)
	//image(spritesheet, 0 ,0 ,80, 80, 240, 0, 80, 80)
	if(frameCount % 4 == 0){
		frame = (frame + 1) % 8
		x = x + 6 * moving;
	}
}
}
/////////////////////////////////



