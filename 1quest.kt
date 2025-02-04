import kotlin.math.pow
import kotlin.math.sqrt

fun main(){

    println("введите 1 число")
    var num1 = readLine()!!.toDouble()
    println("введите 2 число")
    var num2 = readLine()!!.toDouble()
    when{
        num1>num2 -> println(num1+1)
        num2>num1 -> println(num2+1)
        num1==num2 -> println(num1.pow(3))
        else -> println("не сошлось")
    }


}