class FibEven:
    def __init__(self, cutoff=100):
        self.last = 0
        self.secondLast = 2
        self.cutoff = cutoff
    def __iter__(self):
        return self
    def next(self):
        temp = 4 * self.secondLast + self.last
        if temp > self.cutoff:
            raise StopIteration
        self.last = self.secondLast
        self.secondLast = temp
        return temp
def main():
    t=int(raw_input().strip())
    for _ in xrange(t):
        n=long(raw_input().strip())
        total=2
        last=0
        secondLast=2
        while 4 * secondLast + last <= n:
            tmp = 4 * secondLast + last
            total += tmp
            last=secondLast
            secondLast=tmp
        print total

if __name__ == '__main__':
    main()
