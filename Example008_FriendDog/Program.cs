int count = 0;
int distatce = 10000;
int first_friend_speed = 1;
int second_friend_speed = 2;
int dog_speed = 5;
int friend = 2;
int time = 0;

while(distatce > 10)
{
    if(friend == 1)
    {
        time = distatce / (first_friend_speed + dog_speed);
        friend = 2;
    }
    else
    {
        time = distatce / (second_friend_speed + dog_speed);
        friend = 1;
    }
    distatce = distatce - (first_friend_speed + second_friend_speed) * time;
    count++;
}
Console.WriteLine(count);