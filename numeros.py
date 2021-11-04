for numero in range(1,101):

    if numero%3==0 and numero%5==0:
        print("mareigua")

    elif numero%3==0:
        print("mare")

    elif numero%5==0:
        print('igua')
    else:
        print(numero)
