package main

import (
	"bufio"
	"fmt"
	"os"
)

func main() {
	var t int
	fmt.Scanln(&t)

	scanner := bufio.NewScanner(os.Stdin)
	for i := 0; i < t && scanner.Scan(); i++ {
		s := scanner.Text()
		var even, odd string
		for index, c := range s {
			if index%2 == 0 {
				even += string(c)
			} else {
				odd += string(c)
			}
		}
		fmt.Println(even, odd)
	}
}
