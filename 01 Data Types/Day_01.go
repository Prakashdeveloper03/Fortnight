package main

import (
	"bufio"
	"fmt"
	"os"
	"strconv"
)

func main() {
	var _ = strconv.Itoa
	var i uint64 = 4
	var d float64 = 4.0
	var s string = "HackerRank "
	scanner := bufio.NewScanner(os.Stdin)
	scanner.Scan()
	numInt, _ := strconv.ParseUint(scanner.Text(), 10, 64)
	scanner.Scan()
	numDouble, _ := strconv.ParseFloat(scanner.Text(), 64)
	scanner.Scan()
	inputString := scanner.Text()
	fmt.Println(i + numInt)
	fmt.Printf("%.1f\n", d+numDouble)
	fmt.Println(s + inputString)
}
