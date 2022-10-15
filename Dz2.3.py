n=int(input('ВВедите число n'))
Listint = []
sum=0
for i in range (1,n+1):
    result=round((1+1/i)**i, 2)
    Listint.append(result)
    sum+=result
print(Listint)
print('Сумма: ',sum)
