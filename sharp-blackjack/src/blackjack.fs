type Suit = | Spades | Clubs | Diamonds | Hearts

type Face = | Two | Three | Four | Five | Six | Seven | Eight | Nine 
            | Ten | Jack | Queen | King | Ace

type Card = {Face:Face; Suit:Suit}

type Deal = | Hand of Card * Card | Hit of Card
 
let suits = [Spades; Clubs; Diamonds; Hearts]

let faces = [Two; Three; Four; Five; Six; Seven; Eight; Nine;
             Ten; Jack; Queen; King; Ace]

let deck = [for suit in suits do
            for face in faces do
                yield {Face=face; Suit=suit}]

let shuffle xs =
    let swap i j (array : _[]) =
        let tmp = array.[i]
        array.[i] <- array.[j]
        array.[j] <- tmp
    let rnd = System.Random()
    let xArray = Seq.toArray xs
    let n = Array.length xArray
    for i in [0..(n-1)] do
        let j = rnd.Next(i, n)
        swap i j xArray
    xArray |> Seq.toList
    
let deal = function
    | card1::card2::remaining -> Some(card1, card2), remaining
    | _ -> None, []

let shuffled = shuffle deck 

printfn "%A" shuffled

let dealed = deal shuffled

printfn "%A" dealed
