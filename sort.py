
y = []

global sales
print 'We are asking you ten values for the sort'
for i in range(0, 10):	
		try:
   		 print 'Value for the position',i+1
 		 sales = input ('Your Value: ')
 		 y.append(sales)
		except:
    		 print 'This Value is Skipped as it is not an integer!'
x=[]
for i in range (0,len(y)):
	x.append(y[i])
z=[]
for i in range (0,len(y)):
	z.append(y[i])
a=[]
for i in range (0,len(y)):
	a.append(y[i])


print "~~~~Here goes table of Value and Position~~~~"
print "****Position*******************Value**"
global j
j=1
for i in range (0,len(x)):
   print " *** ",j, "        ***           ", x[i],"***"
   print " *****************************************"
   i=i+1
   j=j+1


def qsort(x, l, r):
    i = l
    j = r
    p = x[l + (r - l) / 2] # pivot element in the middle
    while i <= j:
        while x[i] < p: i += 1
        while x[j] > p: j -= 1
        if i <= j: # swap 
            x[i], x[j] = x[j], x[i]
            i += 1
            j -= 1
    if l < j: # sort left list
        qsort(x, l, j)
    if i < r: # sort right list
        qsort(x, i, r)
    return x

def bubble_sort(seq):
    changed = True
    while changed:
        changed = False
        for i in xrange(len(seq) - 1):
            if seq[i] > seq[i+1]:
                seq[i], seq[i+1] = seq[i+1], seq[i]
                changed = True
    return seq

def insertion_sort(examplelist):
       for j in range(1, len(examplelist)):
        key = examplelist[j]
        i = j - 1
        while i > -1 and examplelist[i] > key:
            examplelist[i+1] = examplelist[i]
            i = i - 1
        examplelist[i+1] = key
       return examplelist

p=[]
def reverse(m):
	k=len(m)
	for i in range(0,len(m)):
		p.append(m[k-1])
		k=k-1
	return p

print "Your Array before Quick sort: ", x
x = qsort(x, 0, len(x) - 1)
print "Your Array after Quick sort: ", x

print "Your Array before bubble sort: ", y
x=bubble_sort(y)
print "Your Array after bubble sort: ", x

print "Your Array before Insertion sort: ", z
x=insertion_sort(z)
print "Your Array after Insertion sort: ", x
print "Your Array before reverse: ", a

x=reverse(a)
print "reverse of your array is :",x
print "Printing Average :"
print reduce(lambda x, y: x + y, x) / len(x)
print "Max value element : ", max(x);
print "Min value element : ", min(x);
