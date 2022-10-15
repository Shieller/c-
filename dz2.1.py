


print('ВВедите число')
float_num=float(input())
sum=0
if float_num<0:
    float_num*=-1
float_str=str(float_num)
for i in float_str:
    if i!='.':
        sum+=int(float(i))
print(sum)