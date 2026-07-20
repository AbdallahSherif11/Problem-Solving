/**
 * @param {number} millis
 * @return {Promise}
 */
async function sleep(millis) {
    const delay = (ms) => new Promise((resolve) => setTimeout(resolve, ms));
    await delay(millis);
}

/** 
 * let t = Date.now()
 * sleep(100).then(() => console.log(Date.now() - t)) // 100
 */