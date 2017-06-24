package main

import(
"CoderBusy/IPLocater"
"fmt"
)

func main() {
	fmt.Println("Test Get IP ...")
	p, _ := IPLocater.New()
	ip := "202.102.227.68"
	ipstr := p.Get(ip)
	fmt.Println(ipstr)
}