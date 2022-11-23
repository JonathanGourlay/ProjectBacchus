import React from "react"
import { PropsWithChildren } from "react"

interface IWrapIfProps {
    condition: boolean
    wrapper: (children: React.ReactNode) => JSX.Element
}

const WrapIf = ({ wrapper, condition, children }: PropsWithChildren<IWrapIfProps>): JSX.Element => {
    return condition ? wrapper(children) : <>{children}</>
}
export default WrapIf
