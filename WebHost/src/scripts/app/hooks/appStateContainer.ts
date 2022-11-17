import { Client } from "@api/client"
import React from "react"
import { createContainer } from "unstated-next"

const useAppState = () => {
    const client = React.useMemo(() => { return new Client(window.location.origin) }, [window.location.origin])
    return { client }
}

export default createContainer(useAppState)