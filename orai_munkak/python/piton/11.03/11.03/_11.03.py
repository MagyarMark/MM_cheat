hom = []

for i in range(7):
    be = int(input('Írjon be egy Hőmérsékletet: '))
    hom.append(be)

print(hom)

db = 0

for h in hom:
    if h < 0: 
        db += 1 # db = db + 1
print(f"A héten {db} alkalommal volt fagy.")

napok = ["hétfő" , "kedd" , "szerda" , "csütörtök" , "péntek" , "szombat" , "vasárnap"]

print("Következő napokon volt fagy: ")
for i in range (len(hom)):
    if hom[i] < 0:
        print(napok[i])