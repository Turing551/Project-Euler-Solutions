def solution():
    t = int(raw_input().strip())
    for _ in range(t):
        n = long(raw_input().strip())
        m3 = (n-1)/3
        m5 = (n-1)/5
        m15 = (n-1)/15
        print (3 * m3 * (m3 + 1) + 5 * m5 * (m5 + 1) - 15 * m15 * (m15 + 1)) / 2

if __name__ == '__main__':
    solution()
