//combotwitch
if(global.timeforepic=true)
{
global.combo+=3;
}
else if(global.timeforsemi = true)
{
global.combo+=2;
}
else
{
global.combo++;
}

drawcombo.y -= 20;
with(drawcombo){alarm[0]=2;}

if(global.combo = 30)
{
    semiepic();
}

if(global.combo = 100)
{
    epic();
}